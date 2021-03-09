#version 330 core
out vec4 FragColor;
  
in vec2 TexCoord;

//Texture Samplers.
uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
    // linearly interpolate between both textures (60% container, 40% awesomeface)
    FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.4); 
}