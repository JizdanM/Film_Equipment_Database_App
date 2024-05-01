module com.general.equiplogs {
    requires javafx.controls;
    requires javafx.fxml;

    requires org.controlsfx.controls;
    requires com.dlsc.formsfx;
    requires org.kordamp.ikonli.javafx;
    requires java.sql;
    requires jakarta.persistence;
    requires java.desktop;

    opens com.general.equiplogs to javafx.fxml;
    opens entity;
    exports com.general.equiplogs;
}