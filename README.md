# SkiaSharp.Forms.Xaml
 xaml extensions for SkiaSharp
 
## Examples


![example](https://user-images.githubusercontent.com/19656249/80853300-19dfa100-8c06-11ea-9b58-e6948367f0e5.gif)


## Getting started

- Install the Xamarin.Forms.NeoControls package

 ```
 Install-Package Xamarin.Forms.NeoControls -Version 1.0.0-pre
 ```

- Add SkiaSharp and xaml extensions namespace to your Xaml page/view

```xaml
        xmlns:skia="clr-namespace:SkiaSharp.Views.Forms;assembly=SkiaSharp.Views.Forms"
        xmlns:skiaXaml="clr-namespace:Skiasharp.Forms.Xaml;assembly=Skiasharp.Forms.Xaml"
```

- Insert your SKCanvasView

```xml
        <skia:SKCanvasView>
        </skia:SKCanvasView>
```
- Create a renderer

```xml
         <skia:SKCanvasView>
            <skiaXaml:DrawSurface.Renderer>
                <skiaXaml:RendererSource>

                </skiaXaml:RendererSource>
            </skiaXaml:DrawSurface.Renderer>
        </skia:SKCanvasView>
```

- Insert your draws

```xml
         <skia:SKCanvasView>
            <skiaXaml:DrawSurface.Renderer>
                <skiaXaml:RendererSource>
                    <skiaXaml:Clear/>

                    <skiaXaml:Rectangle X="{Binding PositionX}"
                                        Y="{Binding PositionY}"
                                        Width="{Binding Width}"
                                        Height="{Binding Height}"
                                        Color="Blue"/>
                        
                    <skiaXaml:Circle CenterX="{Binding PositionX}"
                                        CenterY="{Binding PositionY}"
                                        Radius="{Binding Radius}"
                                        StrokeWidth="{Binding StrokeWidth}"
                                        Color="Red" Style="Stroke"/>


                </skiaXaml:RendererSource>
            </skiaXaml:DrawSurface.Renderer>
            </skia:SKCanvasView>
```
