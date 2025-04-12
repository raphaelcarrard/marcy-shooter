using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Tempo());
    }

    IEnumerator Tempo(){
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Game");
    }
}