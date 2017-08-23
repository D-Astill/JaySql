using UnityEngine;

public class Item
{
    private int id, clipsize, weight;
    private string name, ammotype, modelname;
    private float damage, firerate, weaponrange;
    private Texture2D iconname;
    public void Init(int iD, string weaponName, Texture2D icon)
    {
        id = iD;
        name = weaponName;
        iconname = icon;
    }
    public int ID
    {
        get { return id; }
        set { id = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int ClipSize
    {
        get { return clipsize; }
        set { clipsize = value; }
    }
    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }
    public string AmmoType
    {
        get { return ammotype; }
        set { ammotype = value; }
    }
    public string ModelName
    {
        get { return modelname; }
        set { modelname = value; }
    }
    public float Damage
    {
        get { return damage; }
        set { damage = value; }
    }
    public float FireRate
    {
        get { return firerate; }
        set { firerate = value; }
    }
    public float WeaponRange
    {
        get { return weaponrange; }
        set { weaponrange = value; }
    }
    public Texture2D IconName
    {
        get { return iconname; }
        set { iconname = value; }
    }
}
