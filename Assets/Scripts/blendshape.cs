using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blendshape : MonoBehaviour
{
	private int index_min;
	private int index_max;
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
		}
		else
		{
			skinnedModel.SetBlendShapeWeight(4, value);
		}
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
