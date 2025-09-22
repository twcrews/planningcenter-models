# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [2.0.0] - 2025-09-22

### Changed

- **Breaking change:** Use `DateTime` in place of `DateOnly` across all models for runtime compatibility.
- Update package to target .NET Standard 2.0 for maximum compatibility.
- Regenerate all models based on current documentation.

## [1.2.0] - 2025-08-27

### Changed

- Regenerated all models based on current documentation.
- Upgraded package dependencies.

## [1.1.0] - 2025-01-23

### Fixed

- Fix an issue where some `date_format` attributes were incorrectly generated as integers due to errors in Planning Center's documentation.

### Changed

- Regenerated all models based on current documentation.

## [1.0.0] - 2024-12-01

Initial release.

[2.0.0]: https://github.com/twcrews/planningcenter-models/compare/1.2.0...2.0.0
[1.2.0]: https://github.com/twcrews/planningcenter-models/compare/1.1.0...1.2.0
[1.1.0]: https://github.com/twcrews/planningcenter-models/compare/1.0.0...1.1.0
[1.0.0]: https://github.com/twcrews/planningcenter-models/releases/tag/1.0.0