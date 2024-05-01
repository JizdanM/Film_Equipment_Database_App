package com.general.equiplogs;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.stage.Stage;

import java.io.IOException;

public class MainApp extends Application {

    // Leave like this for now. Might require changes in the future
    @Override
    public void start(Stage stage) throws IOException {
        FXMLLoader fxmlLoader = new FXMLLoader(MainApp.class.getResource("main-view.fxml"));
        Scene scene = new Scene(fxmlLoader.load(), 1200, 700);
        stage.setTitle("Loguri Echipamente");
        stage.setScene(scene);
        stage.show();
    }

    // Window launch
    public static void main(String[] args) {
        launch();
    }
}