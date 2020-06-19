using UnityEngine;
using System.Collections;

public class StartButtonScript : MonoBehaviour {

    public void OnClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene1");
    }

}
