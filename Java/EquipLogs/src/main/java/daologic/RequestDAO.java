package daologic;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class RequestDAO {
    ConnectDAO connectDAO = new ConnectDAO();
    Connection connection = connectDAO.getConnection();

    /*
    /// -----Database calls
     */
    // TODO: Define all the SQL resquests needed
    public static final String REQ_EQUIPMENT = "SELECT * FROM equipment";
    public static final String REQ_EQUIPMENT_USR = "SELECT equipment.id, equipname, catname FROM equipment INNER JOIN category ON equipment.categoryid = category.id";
    public static final String REQ_CATEGORY = "SELECT * FROM category";
    public static final String REQ_STUDENTS = "SELECT * FROM students";
    public static final String REQ_LOGS = "SELECT * FROM logs";
    public static final String REQ_LOGS_USR = "SELECT logs.id, equipname, name, surname, lenddate, returned, class, email, phonenumber FROM logs INNER JOIN equipment ON logs.equipment = equipment.id INNER JOIN students ON logs.student = students.id";

    /*
    /// -----Connection to database
     */
    // TODO: Improve the request. Make it return either an array or data, or formated table columns
    public ResultSet requestData(String requestLine) throws SQLException {
        Statement statement = connection.createStatement();
        ResultSet output = statement.executeQuery(requestLine);

        return output;
    }
}
