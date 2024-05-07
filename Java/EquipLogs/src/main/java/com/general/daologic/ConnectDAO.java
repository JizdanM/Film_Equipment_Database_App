package com.general.daologic;

import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;

public class ConnectDAO {
    public Connection databaseLink;
    private String databaseName;
    private String databaseUser;
    private String databasePassword;

    JSONParser jsonParser = new JSONParser();

    public Connection getConnection() throws IOException, ParseException, FileNotFoundException {
        JSONObject jsonObject = (JSONObject) jsonParser.parse(new FileReader("src/main/java/configuration/config.json"));
        databaseName = (String) jsonObject.get("databaseName");
        databaseUser = (String) jsonObject.get("databaseUser");
        databasePassword = (String) jsonObject.get("databasePassword");
        String url = "jdbc:postgresql://localhost:5432/" + databaseName;

        try {
            Class.forName("org.postgresql.Driver");

            databaseLink = DriverManager.getConnection(url, databaseUser, databasePassword);
        } catch (Exception e) {
            e.printStackTrace();
        }

        return databaseLink;
    }


}
