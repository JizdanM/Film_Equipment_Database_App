package com.general.equiplogs;

import daologic.RequestDAO;
import entity.Equipment;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.cell.PropertyValueFactory;

import java.sql.ResultSet;

public class MainController {
    @FXML
    private TableView equipTable;

    @FXML
    protected void settingsBtn() {
        // TODO: Create a simple setting window (Language / Theme etc.)
    }

    @FXML
    protected void closeBtn() {
        System.exit(0);
    }

    @FXML
    protected void showEquipmentBtn() {
        try {
            equipTable.getColumns().clear();

            TableColumn<Equipment, Integer> idColumn = new TableColumn<>("ID");
            idColumn.setCellValueFactory(new PropertyValueFactory<>("id"));

            TableColumn<Equipment, String> equipmentColumn = new TableColumn<>("Equipment");
            equipmentColumn.setCellValueFactory(new PropertyValueFactory<>("equipName"));

            TableColumn<Equipment, Integer> categoryColumn = new TableColumn<>("Category");
            categoryColumn.setCellValueFactory(new PropertyValueFactory<>("catID"));

            equipTable.getColumns().addAll(idColumn, equipmentColumn, categoryColumn);
            equipTable.setColumnResizePolicy(TableView.CONSTRAINED_RESIZE_POLICY_ALL_COLUMNS);

            ResultSet output = new RequestDAO().requestData(RequestDAO.REQ_EQUIPMENT);
            ObservableList<Equipment> equipList = FXCollections.observableArrayList();

            while(output.next()){
                Equipment equip = new Equipment(output.getInt("id"), output.getString("equipname"), output.getInt("categoryid"));
                equipList.add(equip);
            }

            equipTable.setItems(equipList);

        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    @FXML
    protected void showCategoryBtn() {

    }

    @FXML
    protected void showStudentsBtn() {

    }

    @FXML
    protected void showLogsBtn() {

    }

    @FXML
    protected void refreshBtnClick() {
        // TODO: Figure out how to call the last request and display it
    }

}