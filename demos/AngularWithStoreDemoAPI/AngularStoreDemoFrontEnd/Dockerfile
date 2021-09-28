# Stage 1
FROM node:latest as build-step
#RUN mkdir -p /app #this step is unneeded bc workdir will create the file if it doesn't exist
WORKDIR /app
COPY package.json /app 
RUN npm install
COPY . /app
RUN npm run build -- --prod
# Stage 2
FROM nginx:alpine
COPY --from=build-step /app/dist/AngularStoreDemoFrontEnd /usr/share/nginx/html

#command to build image
# docker build -t markmooredocker/batch08162021docker:angularfe1 .

# command to run the Angular image as a container
# docker run -dp 4200:80 --name <desiredcontainername> <imagename>