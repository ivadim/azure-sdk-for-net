// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary>
    /// Details about resource onboarding status across all connectors.
    ///
    /// OnboardedByOtherConnector - this resource has already been onboarded to another connector. This is only applicable to top-level resources.
    /// Onboarded - this resource has already been onboarded by the specified connector.
    /// NotOnboarded - this resource has not been onboarded to any connector.
    /// NotApplicable - the onboarding state is not applicable to the current endpoint.
    /// </summary>
    public readonly partial struct OnboardingState : IEquatable<OnboardingState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OnboardingState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OnboardingState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotApplicableValue = "NotApplicable";
        private const string OnboardedByOtherConnectorValue = "OnboardedByOtherConnector";
        private const string OnboardedValue = "Onboarded";
        private const string NotOnboardedValue = "NotOnboarded";

        /// <summary> NotApplicable. </summary>
        public static OnboardingState NotApplicable { get; } = new OnboardingState(NotApplicableValue);
        /// <summary> OnboardedByOtherConnector. </summary>
        public static OnboardingState OnboardedByOtherConnector { get; } = new OnboardingState(OnboardedByOtherConnectorValue);
        /// <summary> Onboarded. </summary>
        public static OnboardingState Onboarded { get; } = new OnboardingState(OnboardedValue);
        /// <summary> NotOnboarded. </summary>
        public static OnboardingState NotOnboarded { get; } = new OnboardingState(NotOnboardedValue);
        /// <summary> Determines if two <see cref="OnboardingState"/> values are the same. </summary>
        public static bool operator ==(OnboardingState left, OnboardingState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OnboardingState"/> values are not the same. </summary>
        public static bool operator !=(OnboardingState left, OnboardingState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OnboardingState"/>. </summary>
        public static implicit operator OnboardingState(string value) => new OnboardingState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OnboardingState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OnboardingState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
