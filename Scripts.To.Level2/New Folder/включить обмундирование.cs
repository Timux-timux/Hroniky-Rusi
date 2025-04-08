using UnityEngine;

public class включитьобмундирование : MonoBehaviour
{

    public GameObject[] Weapon; 

    void Start()
    {

        for (int i = 0; i < Weapon.Length; i++)
            Weapon[i].SetActive(true);
        
    }

    
}
