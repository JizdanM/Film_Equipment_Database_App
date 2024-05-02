package com.general.equiplogs;

import daologic.RequestDAO;
import entity.Category;
import entity.Equipment;
import entity.Logs;
import entity.Student;
import javafx.beans.property.SimpleStringProperty;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.*;
import javafx.scene.control.cell.PropertyValueFactory;

import java.sql.Date;
import java.sql.ResultSet;

public class MainController {
    @FXML
    private TableView equipTable;

    @FXML
    private MenuItem btnSetting;
    @FXML
    private MenuItem btnExit;
    @FXML
    private MenuItem btnShowEquipment;
    @FXML
    private MenuItem btnShowCategory;
    @FXML
    private MenuItem btnShowStudents;
    @FXML
    private MenuItem btnShowLogs;
    @FXML
    private MenuItem btnAdd;
    @FXML
    private MenuItem btnEdit;
    @FXML
    private MenuItem btnDelete;

    @FXML
    private Button btnReturn;

    /*
    /// -----Constructors / Initializers
     */

    @FXML
    private void initialize() {
        // TODO: Find a bette way to hide "Return" button (if possible)
        btnSetting.setOnAction(actionEvent -> {
            hideReturnButton();
            settingsBtn();
        });

        btnExit.setOnAction(event -> close());

        btnShowEquipment.setOnAction(event -> {
            hideReturnButton();
            showEquipment();
        });

        btnShowCategory.setOnAction(event -> {
            hideReturnButton();
            showCategory();
        });

        btnShowStudents.setOnAction(event -> {
            hideReturnButton();
            showStudents();
        });

        btnShowLogs.setOnAction(event -> {
            showReturnButton();
            showLogs();
        });

        btnAdd.setOnAction(event -> {
            hideReturnButton();
            // Function for data insertion              (!!--REPLACE--!!)
        });

        btnEdit.setOnAction(event -> {
            hideReturnButton();
            // Function for data editing                (!!--REPLACE--!!)
        });

        btnDelete.setOnAction(event -> {
            hideReturnButton();
            // Function for data deleting               (!!--REPLACE--!!)
        });
    }

    /*
    /// -----Menu buttons functions
     */

    @FXML
    protected void settingsBtn() {
        // TODO: Create a simple setting window (Language / Theme etc.)
    }

    @FXML
    protected void close() {
        System.exit(0);
    }

    @FXML
    protected void showEquipment() {
        try {
            equipTable.getColumns().clear();

            TableColumn<Equipment, Integer> idColumn = new TableColumn<>("ID");
            idColumn.setCellValueFactory(new PropertyValueFactory<>("id"));

            TableColumn<Equipment, String> equipmentColumn = new TableColumn<>("Echipament");
            equipmentColumn.setCellValueFactory(new PropertyValueFactory<>("equipName"));

            TableColumn<Equipment, String> categoryColumn = new TableColumn<>("Categorie");
            categoryColumn.setCellValueFactory(new PropertyValueFactory<>("category"));

            equipTable.getColumns().addAll(idColumn, equipmentColumn, categoryColumn);
            equipTable.setColumnResizePolicy(TableView.CONSTRAINED_RESIZE_POLICY_ALL_COLUMNS);

            ResultSet output = new RequestDAO().requestData(RequestDAO.REQ_EQUIPMENT_USR);
            ObservableList<Equipment> equipList = FXCollections.observableArrayList();

            while(output.next()){
                Equipment equip = new Equipment(output.getInt("id"), output.getString("equipname"), output.getString("catname"));
                equipList.add(equip);
            }

            equipTable.setItems(equipList);

        } catch (Exception e) {
            e.printStackTrace(System.out);
        }
    }

    @FXML
    protected void showCategory() {
        try {
            equipTable.getColumns().clear();

            TableColumn<Category, Integer> idColumn = new TableColumn<>("ID");
            idColumn.setCellValueFactory(new PropertyValueFactory<>("id"));

            TableColumn<Category, String> categoryColumn = new TableColumn<>("Categorie");
            categoryColumn.setCellValueFactory(new PropertyValueFactory<>("category"));

            equipTable.getColumns().addAll(idColumn, categoryColumn);
            equipTable.setColumnResizePolicy(TableView.CONSTRAINED_RESIZE_POLICY_ALL_COLUMNS);

            ResultSet output = new RequestDAO().requestData(RequestDAO.REQ_CATEGORY);
            ObservableList<Category> categoryList = FXCollections.observableArrayList();

            while(output.next()){
                Category category = new Category(output.getInt("id"), output.getString("catname"));
                categoryList.add(category);
            }

            equipTable.setItems(categoryList);

        } catch (Exception e) {
            e.printStackTrace(System.out);
        }
    }

    @FXML
    protected void showStudents() {
        try {
            equipTable.getColumns().clear();

            TableColumn<Student, Integer> idColumn = new TableColumn<>("ID");
            idColumn.setCellValueFactory(new PropertyValueFactory<>("id"));

            TableColumn<Student, String> nameColumn = new TableColumn<>("Nume");
            nameColumn.setCellValueFactory(new PropertyValueFactory<>("name"));

            TableColumn<Student, String> surnameColumn = new TableColumn<>("Prenume");
            surnameColumn.setCellValueFactory(new PropertyValueFactory<>("surname"));

            TableColumn<Student, String> groupColumn = new TableColumn<>("Grupa");
            groupColumn.setCellValueFactory(new PropertyValueFactory<>("group"));

            TableColumn<Student, String> emailColumn = new TableColumn<>("Email");
            emailColumn.setCellValueFactory(new PropertyValueFactory<>("email"));

            TableColumn<Student, String> phoneNumberColumn = new TableColumn<>("NrTelefon");
            phoneNumberColumn.setCellValueFactory(new PropertyValueFactory<>("phoneNr"));

            equipTable.getColumns().addAll(idColumn, nameColumn, surnameColumn, groupColumn, emailColumn, phoneNumberColumn);
            equipTable.setColumnResizePolicy(TableView.CONSTRAINED_RESIZE_POLICY_ALL_COLUMNS);

            ResultSet output = new RequestDAO().requestData(RequestDAO.REQ_STUDENTS);
            ObservableList<Student> studentList = FXCollections.observableArrayList();

            while(output.next()){
                Student student = new Student(output.getInt("id"), output.getString("name")
                        , output.getString("surname"), output.getString("class")
                        , output.getString("email"), output.getString("phonenumber"));
                studentList.add(student);
            }

            equipTable.setItems(studentList);

        } catch (Exception e) {
            e.printStackTrace(System.out);
        }
    }

    @FXML
    protected void showLogs() {
        try {
            equipTable.getColumns().clear();

            TableColumn<Logs, Integer> idColumn = new TableColumn<>("ID");
            idColumn.setCellValueFactory(new PropertyValueFactory<>("id"));

            TableColumn<Logs, String> equipNameColumn = new TableColumn<>("Echipament");
            equipNameColumn.setCellValueFactory(cellData -> {
                Equipment equipment = cellData.getValue().getEquipment();
                if (equipment != null) {
                    return new SimpleStringProperty(equipment.getEquipName());
                }
                return new SimpleStringProperty("");
            });

            TableColumn<Logs, String> categoryNameColumn = new TableColumn<>("Categorie");
            categoryNameColumn.setCellValueFactory(new PropertyValueFactory<>("category"));

            TableColumn<Logs, String> nameColumn = new TableColumn<>("Nume");
            nameColumn.setCellValueFactory(cellData -> {
                Student student = cellData.getValue().getStudent();
                if (student != null) {
                    return new SimpleStringProperty(student.getName());
                }
                return new SimpleStringProperty("");
            });

            TableColumn<Logs, String> surnameColumn = new TableColumn<>("Prenume");
            surnameColumn.setCellValueFactory(cellData -> {
                Student student = cellData.getValue().getStudent();
                if (student != null) {
                    return new SimpleStringProperty(student.getSurname());
                }
                return new SimpleStringProperty("");
            });

            TableColumn<Logs, String> studentClassColumn = new TableColumn<>("Clasa");
            studentClassColumn.setCellValueFactory(cellData -> {
                Student student = cellData.getValue().getStudent();
                if (student != null) {
                    return new SimpleStringProperty(student.getGroup());
                }
                return new SimpleStringProperty("");
            });

            TableColumn<Logs, String> emailColumn = new TableColumn<>("Email");
            emailColumn.setCellValueFactory(cellData -> {
                Student student = cellData.getValue().getStudent();
                if (student != null) {
                    return new SimpleStringProperty(student.getEmail());
                }
                return new SimpleStringProperty("");
            });

            TableColumn<Logs, String> phoneNumberColumn = new TableColumn<>("NrTelefon");
            phoneNumberColumn.setCellValueFactory(cellData -> {
                Student student = cellData.getValue().getStudent();
                if (student != null) {
                    return new SimpleStringProperty(student.getPhoneNr());
                }
                return new SimpleStringProperty("");
            });

            TableColumn<Logs, Date> lendDateColumn = new TableColumn<>("Data imprumutarii");
            lendDateColumn.setCellValueFactory(new PropertyValueFactory<>("lendDate"));

            TableColumn<Logs, Boolean> returnedColumn = new TableColumn<>("Returnat");
            returnedColumn.setCellValueFactory(new PropertyValueFactory<>("returned"));

            equipTable.getColumns().addAll(idColumn, equipNameColumn, categoryNameColumn, nameColumn, surnameColumn
                    , studentClassColumn, emailColumn, phoneNumberColumn, lendDateColumn, returnedColumn);
            equipTable.setColumnResizePolicy(TableView.CONSTRAINED_RESIZE_POLICY_ALL_COLUMNS);

            ResultSet output = new RequestDAO().requestData(RequestDAO.REQ_LOGS_USR);
            ObservableList<Logs> logList = FXCollections.observableArrayList();

            while(output.next()){
                Logs log = new Logs(output.getInt("log")
                        , new Equipment(output.getInt("equipment"), output.getString("equipname")
                                , output.getString("catname"))
                        , new Student(output.getInt("student"), output.getString("name")
                                , output.getString("surname"), output.getString("class")
                                , output.getString("email"), output.getString("phonenumber"))
                        , output.getDate("lenddate"), output.getBoolean("returned"));
                logList.add(log);
            }

            equipTable.setItems(logList);

        } catch (Exception e) {
            e.printStackTrace(System.out);
        }
    }

    /*
    /// -----Interaction buttons functions
     */

    @FXML
    protected void returnedBtnClick() {
        try {
            Logs selectedEquipment = (Logs) equipTable.getSelectionModel().getSelectedItem();

            if (selectedEquipment != null) {
                int id = selectedEquipment.getId();

                int updatedLines = new RequestDAO().updateCall(RequestDAO.RETURN_EQUIPMENT + id);
                if (updatedLines != 0){
                    showMessage("Echipamentul a fost returnat");
                    showLogs();
                } else {
                    showError("Aplicatia nu a putut edita baza de date");
                }
            } else {
                showError("Nu ati selectat logul!");
            }

        } catch (Exception e) {
            e.printStackTrace(System.out);
        }
    }

    @FXML
    protected void refreshBtnClick() {
        // TODO: Figure out how to call the last request and display it
    }

    /*
    /// -----Helper functions
    */
    @FXML
    protected void showReturnButton() {
        btnReturn.setOpacity(1);
        btnReturn.setDisable(false);
    }

    @FXML
    private void hideReturnButton() {
        btnReturn.setOpacity(0);
        btnReturn.setDisable(true);
    }

    private void showError(String message) {
        Alert alert = new Alert(Alert.AlertType.ERROR);
        alert.setTitle("Eroare");
        alert.setHeaderText(null);
        alert.setContentText(message);
        alert.showAndWait();
    }

    private void showMessage(String message) {
        Alert alert = new Alert(Alert.AlertType.INFORMATION);
        alert.setTitle("Mesaj");
        alert.setHeaderText(null);
        alert.setContentText(message);
        alert.showAndWait();
    }

}