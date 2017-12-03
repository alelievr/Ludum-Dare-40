Shader "Hidden/Distort" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_DisplacementTex ("Displacement", 2D) = "white" {}
		_bwBlend ("Black & White blend", Range (0, 1)) = 0
		_Zoom ("Zoom", Float) = 1
		_Speed ("Speed", Float) = 1
		_Strength ("Strength", Range(0, 1)) = 0
	}
	SubShader {
		Pass {
			CGPROGRAM
			#pragma vertex vert_img
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			
			sampler2D _MainTex;
			sampler2D _DisplacementTex;
			float _bwBlend;
			float _Strength;
			float _Zoom;
			float _Speed;
			
			float4 frag(v2f_img i) : COLOR {
				float4 n = tex2D(_DisplacementTex, (i.uv + _Time.x * _Speed) * _Zoom);
				float2 d = n.yz * 2 - 1;
				float2 uv = i.uv;
				uv += float2(0, d.y) * _Strength;
				uv = saturate(uv);
				return tex2D(_MainTex, uv);
			}
			ENDCG
		}
	}
}
