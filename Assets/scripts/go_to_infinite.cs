using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go_to_infinite : MonoBehaviour
{
  public void toinfinite()
    {
        SceneManager.LoadScene("infinite");
    }
}
