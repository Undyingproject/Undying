using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    public PlatformMove platform;
    private void OnTriggerEnter(Collider other)
    {
        platform.NextPlatform();
    }
}