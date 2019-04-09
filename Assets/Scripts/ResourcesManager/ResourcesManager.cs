using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager : MonoBehaviour {

    public static Dictionary<string, GameObject> prefabDic = new Dictionary<string, GameObject>();
    public static Dictionary<string, SpringJoint> spDic = new Dictionary<string, SpringJoint>();
    void Awake()
    {

        load(ResName.bagItem);
            
     }



    public void load(string res_name)
    {
        GameObject g = Resources.Load<GameObject>(res_name);
        prefabDic.Add(res_name,g);
    
    }


    
}
