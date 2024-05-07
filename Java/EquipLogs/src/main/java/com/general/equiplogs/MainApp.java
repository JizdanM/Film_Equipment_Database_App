package com.general.equiplogs;

import com.general.controllers.MainController;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.stage.Modality;
import javafx.stage.Stage;

import java.io.IOException;

public class MainApp extends Application {

    // Leave like this for now. Might require changes in the future
    @Override
    public void start(Stage stage) throws Exception {
        FXMLLoader fxmlLoader = new FXMLLoader(MainApp.class.getResource("main-view.fxml"));
        Scene scene = new Scene(fxmlLoader.load(), 1200, 700);

        stage.setTitle("Loguri Echipamente");
        stage.setScene(scene);
        stage.show();

        new MainController().setStage(stage);
    }

    // Window launch
    public static void main(String[] args) {
        launch();
    }
}