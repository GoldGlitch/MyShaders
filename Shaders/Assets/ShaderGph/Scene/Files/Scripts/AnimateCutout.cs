using UnityEngine;

namespace AdvancedDissolve_Example
{
    public class AnimateCutout : MonoBehaviour
    {
        public bool updateGI;


        Renderer mRenderer;
        Material material;

        float offset;
        float speed;
        

        private void Start()
        {
            mRenderer = GetComponent<Renderer>();

            material = mRenderer.material;

            offset = Random.value;
            speed = Random.Range(0.1f, 0.2f);
        }

        // Update is called once per frame
        void Update()
        {

            material.SetFloat("_DissolveCutoff", Mathf.PingPong(offset + Time.time * speed, 1));


            if (updateGI)
            {

                material.SetVector("_Dissolve_ObjectWorldPos", transform.position);



                RendererExtensions.UpdateGIMaterials(mRenderer);
            }
        }
    }
}