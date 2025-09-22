#!/bin/bash
SECONDS=0
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"

HTTP_EXTENSIONS_VERSION="2.0.0"
HTTP_EXTENSIONS_FRAMEWORK="net8.0"

PRIMITIVES_EXTENSIONS_VERSION="1.1.2"
PRIMITIVES_EXTENSIONS_FRAMEWORK="net8.0"

MS_OPTIONS_VERSION="9.0.0"
MS_OPTIONS_FRAMEWORK="net9.0"

printf "Building project...\n"
dotnet build "$SCRIPT_DIR"
printf "\n\n================\n\n"

printf "You can safely ignore errors that begin with 'Could not write output file'."

printf "Generating model entities...\n"
t4 \
	-r "$HOME/.nuget/packages/crews.extensions.http/$HTTP_EXTENSIONS_VERSION/lib/$HTTP_EXTENSIONS_FRAMEWORK/Crews.Extensions.Http.dll" \
	-r "$HOME/.nuget/packages/crews.extensions.primitives/$PRIMITIVES_EXTENSIONS_VERSION/lib/$PRIMITIVES_EXTENSIONS_FRAMEWORK/Crews.Extensions.Primitives.dll" \
	-r "$HOME/.nuget/packages/microsoft.extensions.options/$MS_OPTIONS_VERSION/lib/$MS_OPTIONS_FRAMEWORK/Microsoft.Extensions.Options.dll" \
	-r "$SCRIPT_DIR/../Crews.PlanningCenter.Models.Generators/bin/Debug/net8.0/Crews.PlanningCenter.Models.Generators.dll" \
	"$SCRIPT_DIR/PlanningCenterEntityGenerator.tt"

printf "Generating parameters...\n"
t4 \
	-r "$HOME/.nuget/packages/crews.extensions.http/$HTTP_EXTENSIONS_VERSION/lib/$HTTP_EXTENSIONS_FRAMEWORK/Crews.Extensions.Http.dll" \
	-r "$HOME/.nuget/packages/crews.extensions.primitives/$PRIMITIVES_EXTENSIONS_VERSION/lib/$PRIMITIVES_EXTENSIONS_FRAMEWORK/Crews.Extensions.Primitives.dll" \
	-r "$HOME/.nuget/packages/microsoft.extensions.options/$MS_OPTIONS_VERSION/lib/$MS_OPTIONS_FRAMEWORK/Microsoft.Extensions.Options.dll" \
	-r "$SCRIPT_DIR/../Crews.PlanningCenter.Models.Generators/bin/Debug/net8.0/Crews.PlanningCenter.Models.Generators.dll" \
	"$SCRIPT_DIR/PlanningCenterParametersGenerator.tt"

printf "\nCompleted in $SECONDS seconds.\n"

printf "\nREMINDER: You can safely ignore errors that begin with 'Could not write output file'.\n"
