using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class installer : MonoBehaviour

{
    float placeinstall = 21.94f;
    int create = 0;
    public  GameObject world;
    //public List<GameObject> wor = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (create == 0)
        {
            create = 1;
            StartCoroutine(insta());
        }
        
    }
    private IEnumerator insta()
    {
        yield return new WaitForSeconds(10);

        GameObject newworld = Instantiate(world, new Vector3(1.64f,8.21f,placeinstall), Quaternion.identity);
        placeinstall += 16.47f;
        create = 0;
        Destroy(newworld,45);
        
        



    }
}
