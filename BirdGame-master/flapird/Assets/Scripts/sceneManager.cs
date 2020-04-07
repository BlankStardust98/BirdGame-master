using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public bool isLogoScene;
    // this checks if the current scene is the logo scene
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine("logoLoad");
    }
    IEnumerator logoLoad() {
        if (isLogoScene == true) {
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene("flapird");
        }
    }
}
