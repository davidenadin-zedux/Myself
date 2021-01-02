using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blendshape : MonoBehaviour
{
    private Slider slider;
	private int index_min;
	private int index_max;
	private float offset = 0.007097f;
	private float offset1 = 0;
	[SerializeField] private GameObject[] hairstyles;
	[SerializeField] SkinnedMeshRenderer skinnedModel;
	public static float heightValue;
	public static float oldValue;

	private void Start()
    {
		hairstyles[0].SetActive(true);
		hairstyles[1].SetActive(false);
		hairstyles[2].SetActive(false);
	}

	public void ValueChangeCheck(float value)
	{
		if (index_min != 4)
		{
			if (value < 0)
			{
				skinnedModel.SetBlendShapeWeight(index_min, -value);
				skinnedModel.SetBlendShapeWeight(index_max, 0);
			}
			else
			{
				skinnedModel.SetBlendShapeWeight(index_max, value);
				skinnedModel.SetBlendShapeWeight(index_min, 0);
			}

			if (index_max == 6)
			{
				for (int i = 0; i < hairstyles.Length; i++)
				{
					if (value < 0)
					{
						hairstyles[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, 0.00003436f * (value + 50) + 0.005379f - offset1);
						offset = 0.00003436f * (value + 50) + 0.005379f;
					}
					else
					{
						hairstyles[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, 0.00006665f * value + 0.007097f - offset1);
						offset = 0.00006665f * value + 0.007097f;
					}
				}

				heightValue = value;
			}

		}
		else
		{
			skinnedModel.SetBlendShapeWeight(4, value);

			for (int i = 0; i < hairstyles.Length; i++)
			{
				hairstyles[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, offset - 0.00000714f * value);
				offset1 = 0.00000714f * value;
			}

			oldValue = value;
		}
	}

	public void setSlider(Slider slid)
    {
		slider = slid;
    }

	public void setHairstyle(int index)
    {
		switch(index)
        {
			case 0:
				hairstyles[0].SetActive(true);
				hairstyles[1].SetActive(false);
				hairstyles[2].SetActive(false);
				break;

			case 1:
				hairstyles[0].SetActive(false);
				hairstyles[1].SetActive(true);
				hairstyles[2].SetActive(false);
				break;

			case 2:
				hairstyles[0].SetActive(false);
				hairstyles[1].SetActive(false);
				hairstyles[2].SetActive(true);
				break;
		}
    }

	public void setIndexMin(int ind)
    {
		index_min = ind;
    }

	public void setIndexMax(int ind)
	{
		index_max = ind;
	}
}
