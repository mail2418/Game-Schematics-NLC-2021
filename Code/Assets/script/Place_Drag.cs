using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place_Drag : MonoBehaviour
{
    [SerializeField] GameObject Hati_Tile;
    [SerializeField] GameObject JG_Tile;
    [SerializeField] GameObject SGTG_Tile;
    [SerializeField] GameObject LGKRN_Tile;
    [SerializeField] GameObject KTPT_Tile;

    [SerializeField] GameObject prefabsObject;
    [SerializeField] GameObject HatiDuplicate;
    [SerializeField] GameObject JGDuplicate;
    [SerializeField] GameObject SGTGDuplicate;
    [SerializeField] GameObject LGKRNDuplicate;
    [SerializeField] GameObject KTPTDuplicate;
    Vector3 JGPos;
    Vector3 SGTGPos;
    Vector3 LGKRNPos;
    Vector3 HatiPos;
    Vector3 KTPTPos;
    GameObject posisiDuplikasi;
    GameObject posisiDuplikasi2;
    GameObject posisiDuplikasi3;
    GameObject posisiDuplikasi4;
    GameObject posisiDuplikasi5;

    // Start is called before the first frame update
    private void Start()
    {
        var Item = (GameObject)Instantiate(prefabsObject,transform.position,Quaternion.identity);
        RectTransform rt = (RectTransform)Item.transform;
        // Item.transform.parent = gameObject.transform;
        Item.transform.SetParent(gameObject.transform);

        JGPos = new Vector3(JG_Tile.transform.position.x,JG_Tile.transform.position.y,0);
        SGTGPos = new Vector3(SGTG_Tile.transform.position.x,SGTG_Tile.transform.position.y,0);
        LGKRNPos = new Vector3(LGKRN_Tile.transform.position.x,LGKRN_Tile.transform.position.y,0);
        HatiPos = new Vector3(Hati_Tile.transform.position.x,Hati_Tile.transform.position.y,0);
        KTPTPos = new Vector3(KTPT_Tile.transform.position.x,KTPT_Tile.transform.position.y,0);

        posisiDuplikasi = GameObject.Find("KTPT_Drag_Tile");
        posisiDuplikasi2 = GameObject.Find("JG_Drag_Tile");
        posisiDuplikasi3 = GameObject.Find("SGTG_Drag_Tile");
        posisiDuplikasi4 = GameObject.Find("LGKRN_Drag_Tile");
        posisiDuplikasi5 = GameObject.Find("Hati_Drag_Tile");
    }
    public void DuplicateObjectHati()
    {
        var ItemHati = (GameObject)Instantiate(HatiDuplicate,HatiPos,Quaternion.identity);
        ItemHati.transform.SetParent(posisiDuplikasi5.transform);
    }
    public void DuplicateObjectJG()
    {
        var ItemJG = (GameObject)Instantiate(JGDuplicate,JGPos,Quaternion.identity);
        ItemJG.transform.SetParent(posisiDuplikasi2.transform);
    }
    public void DuplicateObjectSGTG()
    {
        var ItemSGTG = (GameObject)Instantiate(SGTGDuplicate,SGTGPos,Quaternion.identity);
        ItemSGTG.transform.SetParent(posisiDuplikasi3.transform);
    }
    public void DuplicateObjectLGKRN()
    {
        var ItemLGKRN = (GameObject)Instantiate(LGKRNDuplicate,LGKRNPos,Quaternion.identity);
        ItemLGKRN.transform.SetParent(posisiDuplikasi4.transform);
    }
    public void DuplicateObjectKTPT()
    {
        var ItemKTPT = (GameObject)Instantiate(KTPTDuplicate,KTPTPos,Quaternion.identity);
        ItemKTPT.transform.SetParent(posisiDuplikasi.transform);
    }
}
