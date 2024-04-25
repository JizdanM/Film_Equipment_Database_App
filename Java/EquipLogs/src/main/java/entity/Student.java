package entity;

public class Student {
    private int id;
    private String nume;
    private String prenume;
    private String group;
    private String email;
    private String phoneNr;

    public Student(int id, String nume, String prenume, String group, String email, String phoneNr) {
        this.id = id;
        this.nume = nume;
        this.prenume = prenume;
        this.group = group;
        this.email = email;
        this.phoneNr = phoneNr;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNume() {
        return nume;
    }

    public void setNume(String nume) {
        this.nume = nume;
    }

    public String getPrenume() {
        return prenume;
    }

    public void setPrenume(String prenume) {
        this.prenume = prenume;
    }

    public String getGroup() {
        return group;
    }

    public void setGroup(String group) {
        this.group = group;
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
