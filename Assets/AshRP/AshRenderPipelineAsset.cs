using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(menuName = "Rendering/AshRenderPipeline")]
public class AshRenderPipelineAsset : RenderPipelineAsset
{
    public Cubemap diffuseIBL;
    public Cubemap specularIBL;
    public Texture brdfLut;

    protected override RenderPipeline CreatePipeline()
    {
        var rp = new AshRenderPipeline();

        rp.diffuseIBL = diffuseIBL;
        rp.specularIBL = specularIBL;
        rp.brdfLut = brdfLut;

        return rp;
    }
}