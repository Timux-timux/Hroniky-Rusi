using UnityEngine;

public class AllIntsLevel4 : MonoBehaviour
{
    public static int TrueAnswers = 0;

    static public bool BookIsOpen = false;

    public int костыль;
    public int костыль2;

    private void Start()
    {
        Scenes = 0;
        TrueAnswers = 0;
    }
    private void Update()
    {
        костыль = TrueAnswers;
        костыль2 = Scenes;
    }

    public static int Scenes = 0;
}
