package entity;

import java.sql.Date;

public class Logs {
    // TODO: Idiot, please implement inheritance for equipment and student
    private int id;
    private int equipmentID;
    private int studentID;
    private String equipName;
    private String name;
    private String surname;
    private Date lendDate;
    private boolean returned;
    private String studentClass;
    private String email;
    private String phoneNr;

    public Logs(int id, int equipmentID, int studentID, Date lendDate, boolean returned) {
        this.id = id;
        this.equipmentID = equipmentID;
        this.studentID = studentID;
        this.lendDate = lendDate;
        this.returned = returned;
    }

    public Logs(int id, String equipName, String name, String surname, Date lendDate, boolean returned, String studentClass, String email, String phoneNr) {
        this.id = id;
        this.equipName = equipName;
        this.name = name;
        this.surname = surname;
        this.lendDate = lendDate;
        this.returned = returned;
        this.studentClass = studentClass;
        this.email = email;
        this.phoneNr = phoneNr;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getStudentID() {
        return studentID;
    }

    public void setStudentID(int studentID) {
        this.studentID = studentID;
    }

    public int getEquipmentID() {
        return equipmentID;
    }

    public void setEquipmentID(int equipmentID) {
        this.equipmentID = equipmentID;
    }

    public String getEquipName() {
        return equipName;
    }

    public void setEquipName(String equipName) {
        this.equipName = equipName;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getSurname() {
        return surname;
    }

    public void setSurname(String surname) {
        this.surname = surname;
    }

    public Date getLendDate() {
        return lendDate;
    }

    public void setLendDate(Date lendDate) {
        this.lendDate = lendDate;
    }

    public boolean isReturned() {
        return returned;
    }

    public void setReturned(boolean returned) {
        this.returned = returned;
    }

    public String getStudentClass() {
        return studentClass;
    }

    public void setStudentClass(String studentClass) {
        this.studentClass = studentClass;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPhoneNr() {
        return phoneNr;
    }

    public void setPhoneNr(String phoneNr) {
        this.phoneNr = phoneNr;
    }
}
