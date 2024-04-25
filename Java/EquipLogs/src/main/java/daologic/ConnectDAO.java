package daologic;

import java.sql.Connection;
import java.sql.DriverManager;

public class ConnectDAO {
    public Connection databaseLink;

    public Connection getConnection() {
        String databaseName = "Echipamente";
        String databaseUser = "postgres";
        String databasePassword = "admin123";
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
