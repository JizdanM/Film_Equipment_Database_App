package entity;

public class Equipment extends Category {
    private String equipName;

    public Equipment(int id, String equipName, String category) {
        super(id, category);
        this.equipName = equipName;
    }

    public String getEquipName() {
        return equipName;
    }

    public void setEquipName(String equipName) {
        this.equipName = equipName;
    }
}
