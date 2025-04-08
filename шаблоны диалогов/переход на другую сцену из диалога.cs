using Unity.VisualScripting;
using UnityEngine;

public class переходнадругуюсценуиздиалога : MonoBehaviour
{
    public GameObject ThisScene;
    public GameObject NextScene;

    private void Update()
    {
        
    }

    void ToNextScene()
    {
        ThisScene.SetActive(false);
        NextScene.SetActive(true);
    }
}
