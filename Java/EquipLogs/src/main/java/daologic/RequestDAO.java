package daologic;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class RequestDAO {
    ConnectDAO connectDAO = new ConnectDAO();
    Connection connection = connectDAO.getConnection();

    // TODO: Define all the SQL resquests needed
    public static final String REQ_EQUIPMENT = "SELECT * FROM equipment";

    // TODO: Improve the request. Make it return either an array or data, or formated table columns
    public ResultSet requestData(String requestLine) throws SQLException {
        Statement statement = connection.createStatement();
        ResultSet output = statement.executeQuery(requestLine);

        return output;
    }
}
