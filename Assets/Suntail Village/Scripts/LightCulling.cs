using UnityEngine;

/*Script to disable lighting and shadows 
when moving away at a set distance*/
namespace Suntail
{
    public class LightCulling : MonoBehaviour
    {
        [SerializeField] private GameObject playerCamera;
        [SerializeField] private float shadowCullingDistance_square = 225f;
        [SerializeField] private float lightCullingDistance_square = 900f;
        private Light _light;
        public bool enableShadows = false;

        private float cameraDistance_square = 0.0f;
        private void Awake()
        {
            _light = GetComponent<Light>();
        }

        private void Update()
        {
            //Calculate the distance between a given object and the light source
            float cameraDistance = Vector3.Distance(playerCamera.transform.position, gameObject.transform.position);
            cameraDistance_square = Vector3.SqrMagnitude(playerCamera.transform.position - gameObject.transform.position);

            if (cameraDistance_square <= shadowCullingDistance_square && enableShadows)
            {
                _light.shadows = LightShadows.Soft;
            }
            else
            {
                _light.shadows = LightShadows.None;
            }

            if (cameraDistance_square <= lightCullingDistance_square)
            {
                _light.enabled = true;
            }
            else
            {
                _light.enabled = false;
            }
        }
    }
}