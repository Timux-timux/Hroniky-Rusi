using UnityEngine;

public class AllIntsLevel4 : MonoBehaviour
{
    public static int TrueAnswers = 0;

    static public bool BookIsOpen = false;

    public int �������;
    public int �������2;

    private void Start()
    {
        Scenes = 0;
        TrueAnswers = 0;
    }
    private void Update()
    {
        ������� = TrueAnswers;
        �������2 = Scenes;
    }

    public static int Scenes = 0;
}
