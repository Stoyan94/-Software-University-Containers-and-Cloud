# build stage
FROM node:14-alpine AS build-stage
WORKDIR /vue_app
COPY package.json ./
RUN npm install
COPY . .
RUN npm run build

# production stage
FROM nginx AS production-stage
COPY --from=build-stage /vue_app/dist /usr/share/nginx/html
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]