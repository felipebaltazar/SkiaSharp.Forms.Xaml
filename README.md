# SkiaSharp.Forms.Xaml
 Xaml extensions for SkiaSharp
 
 ![Build and publish packages](https://github.com/felipebaltazar/SkiaSharp.Forms.Xaml/workflows/Build%20and%20publish%20packages/badge.svg?branch=master)

## Examples

![example](https://user-images.githubusercontent.com/19656249/80853300-19dfa100-8c06-11ea-9b58-e6948367f0e5.gif)


## Getting started

- Install the SkiaSharp.Forms.Xaml package

 ```
 Install-PackageSkiaSharp.Forms.Xaml -Version 1.1.0-pre
 ```

- Add SkiaSharp and xaml extensions namespace to your Xaml page/view

```xaml
        xmlns:skia="clr-namespace:SkiaSharp.Views.Forms;assembly=SkiaSharp.Views.Forms"
        xmlns:skiaXaml="clr-namespace:SkiaSharp.Forms.Xaml;assembly=SkiaSharp.Forms.Xaml"
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

## Draw Support

| Draw            | Xaml Support |
| --------------- | ------------ |
| `Rectangle`     |      ✅     |
| `Circle`        |      ✅     |
| `Text`          |      ✅     |
| `Path`          |      ✅     |