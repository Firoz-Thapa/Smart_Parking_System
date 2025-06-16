using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MaterialSetter : MonoBehaviour {


    public Material Main;
    public List<MeshRenderer> AllM = new List<MeshRenderer>();

	void Update () { 
        if (Main != null)
        {
            MeshRenderer[] renderers = GetComponentsInChildren<MeshRenderer>();
            foreach (var r in renderers)
            {
      
                r.material = Main;
            }
        }
	}
}
