Shader "Unlit/SeeThrough"
{
    
    SubShader
    {
       Tags {"Queue" = "Transparent+1"}
        Pass {Blend Zero One}
    }
}
