using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteraction : MonoBehaviour
{
    public Material mat;
    private float _bits;
    [Header("시작할 bit count")]
    public float startBitsCount = 4;
    [Header("증가할 bit count")]
    public float bitsCount = 10;
    [Header("적용할 이미지 리스트")]
    public List<Texture> textureList = new List<Texture>();
    private Texture _selectedTexture;
    private int textureCount = 0;

    private void Start()
    {
        mat.SetFloat("_Bits", startBitsCount);
        _selectedTexture = textureList[0];
        mat.SetTexture("_MainTex", _selectedTexture);
    }

    private void Update()
    {
        

        // 마우스 왼쪽 클릭 시 비트 카운트 증가
        if (Input.GetMouseButtonDown(0))
        {
            _bits += bitsCount;
            mat.SetFloat("_Bits", _bits);
        }

        // 마우스 오른쪽 클릭 시 이미지 전환
        else if(Input.GetMouseButtonDown (1))
        {
            // 이미지 전환했을 때 초기화
            _bits = startBitsCount;
            mat.SetFloat("_Bits", startBitsCount);

            textureCount++;
            if (textureCount >= textureList.Count)
            {
                textureCount = 0;
            }

            _selectedTexture = textureList[textureCount];
            mat.SetTexture("_MainTex", _selectedTexture);
        }
    }
}
