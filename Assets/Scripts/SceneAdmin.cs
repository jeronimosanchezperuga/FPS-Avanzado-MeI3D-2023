using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAdmin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PersistentData.score);
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene("Juego");
    }
}
