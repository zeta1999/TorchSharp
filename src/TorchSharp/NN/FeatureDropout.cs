﻿using System;
using System.Runtime.InteropServices;
using TorchSharp.Tensor;

namespace TorchSharp.NN
{
    /// <summary>
    /// This class is used to represent a dropout module for 2d/3d convolutational layers.
    /// </summary>
    public class FeatureDropout : FunctionalModule<FeatureDropout>
    {
        internal FeatureDropout() : base()
        {
        }

        [DllImport("LibTorchSharp")]
        private static extern IntPtr THSNN_featureDropoutApply(IntPtr tensor);

        public override TorchTensor Forward(TorchTensor tensor)
        {
            return new TorchTensor(THSNN_featureDropoutApply(tensor.Handle));
        }
    }
}
