using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tryAgainbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public void next()
    {
        SceneManager.LoadScene("Level1");
    }
}
