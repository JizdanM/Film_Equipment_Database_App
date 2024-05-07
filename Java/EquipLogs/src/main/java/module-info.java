module com.general.equiplogs {
    requires javafx.controls;
    requires javafx.fxml;

    requires org.controlsfx.controls;
    requires com.dlsc.formsfx;
    requires org.kordamp.ikonli.javafx;
    requires java.sql;
    requires jakarta.persistence;
    requires java.desktop;
    requires jdk.compiler;
    requires json.simple;

    opens com.general.equiplogs to javafx.fxml;
    opens entity;
    exports com.general.equiplogs;
    exports com.general.controllers;
    opens com.general.controllers to javafx.fxml;
}