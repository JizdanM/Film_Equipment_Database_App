package entity;

public class Equipment {
    private int id;
    private String equipName;
    private int catID;

    public Equipment(int id, String equipName, int catID) {
        this.id = id;
        this.equipName = equipName;
        this.catID = catID;
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

    public int getCatID() {
        return catID;
    }

    public void setCatID(int catID) {
        this.catID = catID;
    }
}
