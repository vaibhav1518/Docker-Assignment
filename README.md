
# Dockerized ASP.NET Core Web API

This project contains a simple ASP.NET Core Web API that is dockerized. Follow the steps below to build and run the project using Docker.

## Prerequisites

- Docker installed on your system.

## Instructions

1. **Navigate to the project directory**:
   
   Open a terminal and navigate to the directory where the project is located:
   ```bash
   cd /path/to/your/project
   ```

2. **Build the Docker image**:
   
   Build the Docker image using `docker-compose`:
   ```bash
   docker-compose build
   ```

3. **Start the Docker containers**:
   
   After building the image, bring up the containers using:
   ```bash
   docker-compose up
   ```

4. **Access the application**:
   
   The application should now be running and accessible via `http://localhost:<exposed-port>`. Check the `docker-compose.yml` file for the exposed port (e.g., `localhost:8080` or `localhost:80`).
