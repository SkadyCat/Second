using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag : MonoBehaviour {



    /// <summary>
    /// 生成背包框
    /// </summary>
    /// <param name="i">第几行</param>
    /// <param name="j">第几列</param>
    public void insBagItem(int i,int j)
    {


       GameObject g =  GameObject.Instantiate(ResourcesManager.prefabDic[ResName.bagItem],this.transform);
       Image img = g.GetComponent<Image>();
       img.sprite = new Sprite();

    }


    void Start()
    {
        insBagItem(1, 1);
        
    }

}
