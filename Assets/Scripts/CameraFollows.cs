using UnityEngine;
using System.Collections;

namespace MarcyShooter
{
    public class CameraFollows : MonoBehaviour
    {
        public Transform target;
        public float smoothing = 5f;
        Vector3 offset;

        void Start()
        {
            offset = transform.position - target.position;
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            Vector3 targetCamPos = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
        }
    }
}
