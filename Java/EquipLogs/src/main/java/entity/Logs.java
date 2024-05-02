package entity;

import java.sql.Date;

public class Logs {
    private int id;
    private Equipment equipment;
    private Student student;
    private Date lendDate;
    private boolean returned;

    public Logs(int id, Equipment equipment, Student student, Date lendDate, boolean returned) {
        this.id = id;
        this.equipment = equipment;
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

    public Equipment getEquipment() {
        return equipment;
    }

    public void setEquipment(Equipment equipment) {
        this.equipment = equipment;
    }

    public Student getStudent() {
        return student;
    }

    public void setStudent(Student student) {
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
