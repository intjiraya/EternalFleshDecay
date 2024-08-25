# EternalFleshDecay

The Exiled SCP:SL plugin, which will help you set up the masking time of SCP-3114.

## Description

EternalFleshDecay is a plugin designed for the SCP: Secret Laboratory game, specifically tailored for the Exiled version. This plugin allows server administrators to customize the masking time of SCP-3114. With this plugin, you can control how long SCP-3114 remains hidden.

## Features

- **Customizable Masking Time**: Easily adjust the duration for which SCP-3114 can remain masked.
- **User-Friendly Configuration**: Simple configuration files that allow for quick adjustments without extensive coding knowledge.
- **Compatibility**: Designed to work seamlessly with the latest version of SCP:SL Exiled.
- **Performance Optimized**: Lightweight and efficient, ensuring minimal impact on server performance.

## Installation

1. Download the latest release of the EternalFleshDecay plugin from the [releases page](#).
2. Place the downloaded `.dll` file into the `plugins` folder of your SCP:SL Exiled server.
3. Restart your server to load the plugin.
4. Configure the plugin settings in the `config.yml` file located in the `plugins/EternalFleshDecay` directory.

## Configuration

The configuration file allows you to set the masking time for SCP-3114. Here’s an example of the configuration options:

```yaml
EternalFleshDecay:
# Plugin Enabled?
  is_enabled: true
  # Enable debug?
  debug: false
  # Time in seconds that SCP-3114 remains disguised. Default - '3.40282347E+38'
  disguise_duration: 3.40282347E+38
```

Adjust the `disguise_duration` value to your desired duration.

## Usage

Once installed and configured, the plugin will automatically apply the specified masking time to SCP-3114 during gameplay. Players will experience the adjusted mechanics without any additional input required.

## Support

For any issues or questions regarding the EternalFleshDecay plugin, please open an issue on the [GitHub repository](#) or join our community Discord server for assistance.

## Contributing

Contributions are welcome! If you would like to contribute to the development of EternalFleshDecay, please fork the repository and submit a pull request. Make sure to follow the coding standards and include appropriate documentation for your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](#) file for more details.
