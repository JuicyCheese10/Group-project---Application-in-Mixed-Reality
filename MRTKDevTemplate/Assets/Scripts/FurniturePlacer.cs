using UnityEngine;

public class FurniturePlacer : MonoBehaviour
{
    public GameObject sofaPrefab;
    public GameObject chairPrefab;
    public GameObject tablePrefab;
    public GameObject bedPrefab; 

    public void PlaceSofa()
    {
        Quaternion sofaRotation = Quaternion.Euler(-100, 0, 0);
        PlaceFurniture(sofaPrefab, sofaRotation);
    }

    public void PlaceChair()
    {
        Quaternion chairRotation = Quaternion.Euler(0, 0, 0); 
        PlaceFurniture(chairPrefab, chairRotation);
    }

    public void PlaceTable()
    {
        Quaternion tableRotation = Quaternion.Euler(0, 0, 0); 
        PlaceFurniture(tablePrefab, tableRotation);
    }

    public void PlaceBed()
    {
        Quaternion bedRotation = Quaternion.Euler(0, 0, 0);
        PlaceFurniture(bedPrefab, bedRotation); 
    }

    private void PlaceFurniture(GameObject furniturePrefab, Quaternion rotation)
    {
        Vector3 positionInFrontOfCamera = Camera.main.transform.position + Camera.main.transform.forward * 2.0f;
        Instantiate(furniturePrefab, positionInFrontOfCamera, rotation);
    }

    private void PlaceFurniture(GameObject furniturePrefab)
    {
        PlaceFurniture(furniturePrefab, Quaternion.identity);
    }
}
