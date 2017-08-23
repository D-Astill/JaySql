using UnityEngine;

public class CreateItem
{
    public static Item CreateAndSplitItem(string ItemId)
    {
        string[] items = ItemId.Split('|');
       
        Item temp = new Item();
        int id = System.Convert.ToInt32(items[0]);
        string name = items[1];
        int clipsize = System.Convert.ToInt32(items[2]);
        float damage = float.Parse(items[3]); 
        float firerate = float.Parse(items[4]); 
        float weaponrange = float.Parse(items[5]); 
        int weight = System.Convert.ToInt32(items[6]);
        string ammotype = items[7];
        string iconname = items[8];
        string modelname = items[9];
        
        temp.ID = id;
        temp.Name = name;
        temp.ClipSize = clipsize;
        temp.Weight = weight;
        temp.AmmoType = ammotype;
        temp.ModelName = modelname;
        temp.Damage = damage;
        temp.FireRate = firerate;
        temp.WeaponRange = weaponrange;
        temp.IconName = Resources.Load("Icons/"+iconname)as Texture2D;
        
        return temp;
    }
}
