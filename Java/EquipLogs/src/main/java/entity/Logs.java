package entity;

import java.sql.Date;

public class Logs {
    private int id;
    private String equipName;
    private String student;
    private Date lendDate;
    private boolean returned;

    public Logs(int id, String equipName, String student, Date lendDate, boolean returned) {
        this.id = id;
        this.equipName = equipName;
        this.student = student;
        this.lendDate = lendDate;
        this.returned = returned;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getEquipName() {
        return equipName;
    }

    public void setEquipName(String equipName) {
        this.equipName = equipName;
    }

    public String getStudent() {
        return student;
    }

    public void setStudent(String student) {
        this.student = student;
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
}
