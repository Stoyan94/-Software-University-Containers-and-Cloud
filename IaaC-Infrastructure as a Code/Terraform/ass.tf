terraform {
  required_providers {
    docker = {
      source  = "kreuzwerker/docker"
      version = "3.0.2"
    }
  }
}

provider "docker" {
  host = "npipe:////./pipe/docker_engine"
}

# Pull the Nginx demo image
resource "docker_image" "nginx_demo" {
  name = "nginxdemos/hello"
}

# Create a Docker container for the Nginx demo
resource "docker_container" "nginx_demo_container" {
  name  = "nginx-demo-container"
  image = resource.docker_image.nginx_demo.name

  ports {
    internal = 80
    external = 8080
  }
}