using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class builder : MonoBehaviour
{   
    public Vector3 terrainArea;
    public GameObject prefab;
    public int amountClones;    
    private float xMinimum, xMaximum, zMinimum, yMinimum, zMaximum;
    
    private void Start() {

        GameObject go = GameObject.Find("Terrain");
        Terrain terrain = go.GetComponent<Terrain>();
        
        terrainArea = terrain.terrainData.size;        
        xMinimum = transform.position.x;
        zMinimum = transform.position.z;
        xMaximum = xMinimum + terrainArea.x;
        zMaximum = zMinimum + terrainArea.z;

        for (int i=0; i < amountClones; i++) {

            InstantiateGameObject();
        }
    }
    private void InstantiateGameObject() {

        GameObject objPos = new GameObject();
        objPos.transform.position = new Vector3(Random.Range(xMinimum, xMaximum), 100f, Random.Range(zMinimum, zMaximum));
        objPos.name = "Builder";

        RaycastHit hit;
        Ray rayDown = new Ray(objPos.transform.position, Vector3.down);

        if (Physics.Raycast (rayDown, out hit, 100)) {
            
            // Debug.Log(hit.distance + " - Height");
            // Debug.Log(hit.point + " - Coordinates");
            prefab = Instantiate(prefab, hit.point, Quaternion.identity);            
            prefab.transform.localScale = new Vector3(0.07414654f, 0.07414654f, 0.07414654f);
            prefab.transform.position = new Vector3(prefab.transform.position.x,
                                                    prefab.transform.position.y,
                                                    prefab.transform.position.z);

            prefab.transform.parent = this.transform;
            Destroy(objPos);
        }
    }
}
