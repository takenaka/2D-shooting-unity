using System.Collections;
using UnityEngine;

public class RockGenerator : MonoBehaviour
{
  public GameObject rockPrefab;
  // Start is called before the first frame update
  void Start()
  {
    InvokeRepeating("GenRock", 1, 1);
  }

  void GenRock()
  {
    Instantiate(rockPrefab, new Vector3(-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
  }
}
