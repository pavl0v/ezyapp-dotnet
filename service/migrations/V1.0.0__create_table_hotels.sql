create table "hotels" (
  "id" uuid not null,
  "name" text not null,
  "created_at" timestamp without time zone default (now() at time zone 'utc'),
  "updated_at" timestamp without time zone default (now() at time zone 'utc'),
  constraint "hotels_pk" primary key ("id")
);
