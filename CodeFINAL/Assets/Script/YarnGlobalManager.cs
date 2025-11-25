using UnityEngine;

public class YarnGlobalManager : MonoBehaviour
{
    private static YarnGlobalManager instance;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);  // ¿ç³¡¾°²»Ïú»Ù
    }
}
