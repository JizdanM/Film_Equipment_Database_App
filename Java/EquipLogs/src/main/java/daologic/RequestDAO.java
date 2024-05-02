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

    /*
    /// -----Requests
     */

    // General calls
    public static final String REQ_EQUIPMENT = "SELECT * FROM equipment ORDER BY id";
    public static final String REQ_CATEGORY = "SELECT * FROM category ORDER BY id";
    public static final String REQ_STUDENTS = "SELECT * FROM students ORDER BY id";
    public static final String REQ_LOGS = "SELECT * FROM logs ORDER BY id";

    // Detailed calls
    public static final String REQ_EQUIPMENT_USR = "SELECT equipment.id, equipment.equipname, category.catname FROM equipment LEFT JOIN category ON equipment.categoryid = category.id ORDER BY equipment.id";
    public static final String REQ_LOGS_USR = "SELECT logs.id AS log, equipment.id AS equipment, equipname, categoryid AS category, catname, students.id AS student, name, surname, class, email, phonenumber, lenddate, returned " +
            "FROM logs LEFT JOIN equipment ON logs.equipment = equipment.id " +
            "LEFT JOIN category ON equipment.categoryid = category.id " +
            "LEFT JOIN students ON logs.student = students.id ORDER BY logs.id";

    /*
    /// -----Edit calls
     */

    public static final String RETURN_EQUIPMENT = "UPDATE logs SET returned = true WHERE id = ";

    /*
    /// -----Connection to database
     */
    // TODO: Improve the request. Make it return either an array or data, or formated table columns
    public ResultSet requestData(String requestLine) throws SQLException {
        Statement statement = connection.createStatement();
        ResultSet output = statement.executeQuery(requestLine);

        return output;
    }

    public int updateCall(String requestLine) throws SQLException {
        Statement statement = connection.createStatement();
        int output = statement.executeUpdate(requestLine);

        return output;
    }
}
