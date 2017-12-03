using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class render_with_shader : MonoBehaviour {
	public float		intensity;
	public float		zoom = 1;
	public float		strength;
	public float		speed;
	private Material	material;
	public Texture2D	distortionTexture;


 	// Creates a private material used to the effect
 	void Awake ()
 	{
	material = new Material( Shader.Find("Hidden/Distort") );
 	}
 
	// Postprocess the image
	void OnRenderImage (RenderTexture source, RenderTexture destination)
	{
		if (intensity == 0)
		{
 			Graphics.Blit (source, destination);
 			return;
 		}

		material.SetTexture("_DisplacementTex", distortionTexture);
 		material.SetFloat("_bwBlend", intensity);
		material.SetFloat("_Strength", strength);
		material.SetFloat("_Speed", speed);
		material.SetFloat("_Zoom", zoom);
 		Graphics.Blit (source, destination, material);
	}
}
