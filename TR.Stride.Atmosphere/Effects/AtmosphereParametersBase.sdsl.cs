﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Stride Shader Mixin Code Generator.
// To generate it yourself, please install Stride.VisualStudio.Package .vsix
// and re-save the associated .sdfx.
// </auto-generated>

using System;
using Stride.Core;
using Stride.Rendering;
using Stride.Graphics;
using Stride.Shaders;
using Stride.Core.Mathematics;
using Buffer = Stride.Graphics.Buffer;

namespace Stride.Rendering
{
    public static partial class AtmosphereParametersBaseKeys
    {
        public static readonly ValueParameterKey<float> BottomRadius = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> TopRadius = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> RayleighDensityExpScale = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<Vector3> RayleighScattering = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<float> MieDensityExpScale = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<Vector3> MieScattering = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<Vector3> MieExtinction = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<Vector3> MieAbsorption = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<float> MiePhaseG = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> AbsorptionDensity0LayerWidth = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> AbsorptionDensity0ConstantTerm = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> AbsorptionDensity0LinearTerm = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> AbsorptionDensity1ConstantTerm = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> AbsorptionDensity1LinearTerm = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<Vector3> AbsorptionExtinction = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<Vector3> GroundAlbedo = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<float> AerialPespectiveViewDistanceScale = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<Vector4> TransmittanceLutResolution = ParameterKeys.NewValue<Vector4>();
        public static readonly ValueParameterKey<Vector4> SkyViewLutResolution = ParameterKeys.NewValue<Vector4>();
        public static readonly ValueParameterKey<Vector4> MultiScatteringLutResolution = ParameterKeys.NewValue<Vector4>();
        public static readonly ValueParameterKey<Vector4> AerialPerspectiveSlicesAndDistancePerSlice = ParameterKeys.NewValue<Vector4>();
        public static readonly ValueParameterKey<float> MultipleScatteringFactor = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<Vector3> SunDirection = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<Vector3> SunIlluminance = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<float> SunLuminanceFactor = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<Matrix> InvViewProjectionMatrix = ParameterKeys.NewValue<Matrix>();
        public static readonly ValueParameterKey<Vector3> CameraPositionWS = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<float> ScaleToSkyUnit = ParameterKeys.NewValue<float>(1.0f);
        public static readonly ValueParameterKey<Vector2> Resolution = ParameterKeys.NewValue<Vector2>();
        public static readonly ValueParameterKey<Vector2> RayMarchMinMaxSPP = ParameterKeys.NewValue<Vector2>();
        public static readonly ObjectParameterKey<Texture> TransmittanceLutTexture = ParameterKeys.NewObject<Texture>();
        public static readonly ObjectParameterKey<Texture> SkyViewLutTexture = ParameterKeys.NewObject<Texture>();
        public static readonly ObjectParameterKey<Texture> MultiScatTexture = ParameterKeys.NewObject<Texture>();
        public static readonly ObjectParameterKey<Texture> AtmosphereCameraScatteringVolume = ParameterKeys.NewObject<Texture>();
    }
}
